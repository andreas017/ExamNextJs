import { WithDefaultLayout } from '@/components/DefautLayout';
import { Title } from '@/components/Title';
import { Restaurant, RestaurantFoodDetailModel } from '@/functions/swagger/ExamNextJs';
import { useSwrFetcherWithAccessToken } from '@/functions/useSwrFetcherWithAccessToken';
import { Page } from '@/types/Page';
import { Alert } from 'antd';
import Link from 'next/link';
import { useRouter } from 'next/router';
import useSwr from 'swr';



const RestaurantGridItem: React.FC<{
    restaurant: RestaurantFoodDetailModel,
}> = ({ restaurant }) => {
    return (
        <div className='border border-gray-400 rounded-xl p-6 flex flex-col items-center bg-white shadow-lg'>
            <div className='bg-slate-400 h-[160px] w-full'></div>
            <div className='mt-4 font-bold'>
                <Link href={`/add-to-cart/${restaurant.foodItemId}`}>
                {restaurant.foodItemName}
                </Link>
                </div>
            <div className='mt-4'>{'Rp.' + restaurant.foodItemPrice?.toLocaleString()}</div>
        </div>

    );
};

const IndexPage: Page = () => {

    const router = useRouter();
    const { id } = router.query;
    const restaurantDetailUri = id ? `/api/be/api/Restaurants/${id}` : undefined;
    const swrFetcher = useSwrFetcherWithAccessToken();
    const { data, error } = useSwr<Restaurant[]>(restaurantDetailUri, swrFetcher);
    return (
        <div>
            <Title>Order Foods</Title>
            <Link href={"/"}>Back to Restaurant List</Link>
            <br />
            <br />
            Please select the food you want to order
            {Boolean(error) && <Alert type='error' message='Cannot get Restaurant data' description={String(error)}></Alert>}
            <div className='grid grid-cols-5 gap-5'>
                {data?.map((x, i) => <RestaurantGridItem key={i} restaurant={x} />)}
            </div>
        </div>
    );
}

IndexPage.layout = WithDefaultLayout;
export default IndexPage;
